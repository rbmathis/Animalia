using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Coryphospingus;

/// <summary>
/// Abstract class for Coryphospingus (genus).
/// NCBI TaxId: 137236
/// </summary>
public abstract class Coryphospingus : Thraupidae, ICoryphospingus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coryphospingus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 137236;

    /// <inheritdoc />
    public virtual string GenusName => "Coryphospingus";

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
