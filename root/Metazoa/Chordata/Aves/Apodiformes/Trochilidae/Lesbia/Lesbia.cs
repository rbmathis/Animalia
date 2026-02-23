using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Lesbia;

/// <summary>
/// Abstract class for Lesbia (genus).
/// NCBI TaxId: 56656
/// </summary>
public abstract class Lesbia : Trochilidae, ILesbia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lesbia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56656;

    /// <inheritdoc />
    public virtual string GenusName => "Lesbia";

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
