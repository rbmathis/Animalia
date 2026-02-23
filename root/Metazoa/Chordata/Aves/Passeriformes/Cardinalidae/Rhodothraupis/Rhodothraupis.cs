using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Rhodothraupis;

/// <summary>
/// Abstract class for Rhodothraupis (genus).
/// NCBI TaxId: 460186
/// </summary>
public abstract class Rhodothraupis : Cardinalidae, IRhodothraupis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhodothraupis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 460186;

    /// <inheritdoc />
    public virtual string GenusName => "Rhodothraupis";

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
