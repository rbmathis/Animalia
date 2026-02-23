using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Hydroprogne;

/// <summary>
/// Abstract class for Hydroprogne (genus).
/// NCBI TaxId: 425640
/// </summary>
public abstract class Hydroprogne : Laridae, IHydroprogne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Hydroprogne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 425640;

    /// <inheritdoc />
    public virtual string GenusName => "Hydroprogne";

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
