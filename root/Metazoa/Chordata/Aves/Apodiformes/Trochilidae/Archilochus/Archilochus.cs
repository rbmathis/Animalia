using AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Apodiformes.Trochilidae.Archilochus;

/// <summary>
/// Abstract class for Archilochus (genus).
/// NCBI TaxId: 190675
/// </summary>
public abstract class Archilochus : Trochilidae, IArchilochus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Archilochus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190675;

    /// <inheritdoc />
    public virtual string GenusName => "Archilochus";

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
