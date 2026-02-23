using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae.Uria;

/// <summary>
/// Abstract class for Uria (genus).
/// NCBI TaxId: 13745
/// </summary>
public abstract class Uria : Alcidae, IUria
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Uria";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 13745;

    /// <inheritdoc />
    public virtual string GenusName => "Uria";

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
