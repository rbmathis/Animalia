using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Ensifera;

/// <summary>
/// Abstract class for Ensifera (genus).
/// NCBI TaxId: 304618
/// </summary>
public abstract class Ensifera : Trochilidae, IEnsifera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ensifera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304618;

    /// <inheritdoc />
    public virtual string GenusName => "Ensifera";

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
