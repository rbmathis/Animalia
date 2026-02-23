using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Biotoecus;

/// <summary>
/// Abstract class for Biotoecus (genus).
/// NCBI TaxId: 119970
/// </summary>
public abstract class Biotoecus : Cichlidae, IBiotoecus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Biotoecus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119970;

    /// <inheritdoc />
    public virtual string GenusName => "Biotoecus";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
