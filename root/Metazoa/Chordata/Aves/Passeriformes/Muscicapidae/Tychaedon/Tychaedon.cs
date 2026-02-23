using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Tychaedon;

/// <summary>
/// Abstract class for Tychaedon (genus).
/// NCBI TaxId: 3478641
/// </summary>
public abstract class Tychaedon : Muscicapidae, ITychaedon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tychaedon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3478641;

    /// <inheritdoc />
    public virtual string GenusName => "Tychaedon";

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
