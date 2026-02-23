using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Catostomidae.Ictiobus;

/// <summary>
/// Abstract class for Ictiobus (genus).
/// NCBI TaxId: 7972
/// </summary>
public abstract class Ictiobus : Catostomidae, IIctiobus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ictiobus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7972;

    /// <inheritdoc />
    public virtual string GenusName => "Ictiobus";

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
