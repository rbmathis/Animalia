using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Geopelia;

/// <summary>
/// Abstract class for Geopelia (genus).
/// NCBI TaxId: 115646
/// </summary>
public abstract class Geopelia : Columbidae, IGeopelia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Geopelia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 115646;

    /// <inheritdoc />
    public virtual string GenusName => "Geopelia";

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
