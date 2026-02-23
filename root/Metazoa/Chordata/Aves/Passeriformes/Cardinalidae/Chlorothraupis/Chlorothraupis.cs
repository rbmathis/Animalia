using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Chlorothraupis;

/// <summary>
/// Abstract class for Chlorothraupis (genus).
/// NCBI TaxId: 62172
/// </summary>
public abstract class Chlorothraupis : Cardinalidae, IChlorothraupis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlorothraupis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62172;

    /// <inheritdoc />
    public virtual string GenusName => "Chlorothraupis";

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
