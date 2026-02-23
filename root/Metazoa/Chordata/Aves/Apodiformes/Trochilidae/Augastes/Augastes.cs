using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Augastes;

/// <summary>
/// Abstract class for Augastes (genus).
/// NCBI TaxId: 1494213
/// </summary>
public abstract class Augastes : Trochilidae, IAugastes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Augastes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1494213;

    /// <inheritdoc />
    public virtual string GenusName => "Augastes";

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
