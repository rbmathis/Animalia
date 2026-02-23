using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Laridae.Gelochelidon;

/// <summary>
/// Abstract class for Gelochelidon (genus).
/// NCBI TaxId: 126864
/// </summary>
public abstract class Gelochelidon : Laridae, IGelochelidon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gelochelidon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 126864;

    /// <inheritdoc />
    public virtual string GenusName => "Gelochelidon";

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
