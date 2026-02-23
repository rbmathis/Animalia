using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cardinalidae.Amaurospiza;

/// <summary>
/// Abstract class for Amaurospiza (genus).
/// NCBI TaxId: 460164
/// </summary>
public abstract class Amaurospiza : Cardinalidae, IAmaurospiza
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amaurospiza";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 460164;

    /// <inheritdoc />
    public virtual string GenusName => "Amaurospiza";

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
