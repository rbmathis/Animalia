using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Hirundinidae.Neochelidon;

/// <summary>
/// Abstract class for Neochelidon (genus).
/// NCBI TaxId: 72870
/// </summary>
public abstract class Neochelidon : Hirundinidae, INeochelidon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neochelidon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 72870;

    /// <inheritdoc />
    public virtual string GenusName => "Neochelidon";

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
