using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Lepidiolamprologus;

/// <summary>
/// Abstract class for Lepidiolamprologus (genus).
/// NCBI TaxId: 32502
/// </summary>
public abstract class Lepidiolamprologus : Cichlidae, ILepidiolamprologus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepidiolamprologus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 32502;

    /// <inheritdoc />
    public virtual string GenusName => "Lepidiolamprologus";

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
