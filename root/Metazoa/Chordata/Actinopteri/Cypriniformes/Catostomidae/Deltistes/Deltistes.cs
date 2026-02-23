using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Deltistes;

/// <summary>
/// Abstract class for Deltistes (genus).
/// NCBI TaxId: 148441
/// </summary>
public abstract class Deltistes : Catostomidae, IDeltistes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Deltistes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 148441;

    /// <inheritdoc />
    public virtual string GenusName => "Deltistes";

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
