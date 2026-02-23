using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Alburnus;

/// <summary>
/// Abstract class for Alburnus (genus).
/// NCBI TaxId: 54555
/// </summary>
public abstract class Alburnus : Leuciscidae, IAlburnus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Alburnus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 54555;

    /// <inheritdoc />
    public virtual string GenusName => "Alburnus";

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
