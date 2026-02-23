using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Etia;

/// <summary>
/// Abstract class for Etia (genus).
/// NCBI TaxId: 302981
/// </summary>
public abstract class Etia : Cichlidae, IEtia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Etia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 302981;

    /// <inheritdoc />
    public virtual string GenusName => "Etia";

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
