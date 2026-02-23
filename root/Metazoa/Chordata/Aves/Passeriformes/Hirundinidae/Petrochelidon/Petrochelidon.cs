using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Petrochelidon;

/// <summary>
/// Abstract class for Petrochelidon (genus).
/// NCBI TaxId: 72883
/// </summary>
public abstract class Petrochelidon : Hirundinidae, IPetrochelidon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Petrochelidon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 72883;

    /// <inheritdoc />
    public virtual string GenusName => "Petrochelidon";

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
