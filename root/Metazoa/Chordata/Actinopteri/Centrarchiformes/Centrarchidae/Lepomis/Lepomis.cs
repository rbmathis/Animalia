using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Centrarchidae.Lepomis;

/// <summary>
/// Abstract class for Lepomis (genus).
/// NCBI TaxId: 13105
/// </summary>
public abstract class Lepomis : Centrarchidae, ILepomis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lepomis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13105;

    /// <inheritdoc />
    public virtual string GenusName => "Lepomis";

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
