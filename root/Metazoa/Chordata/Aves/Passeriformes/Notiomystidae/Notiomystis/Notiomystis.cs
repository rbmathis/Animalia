using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Notiomystidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Notiomystidae.Notiomystis;

/// <summary>
/// Abstract class for Notiomystis (genus).
/// NCBI TaxId: 366453
/// </summary>
public abstract class Notiomystis : Notiomystidae, INotiomystis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Notiomystis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 366453;

    /// <inheritdoc />
    public virtual string GenusName => "Notiomystis";

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
