using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Paranotropis;

/// <summary>
/// Abstract class for Paranotropis (genus).
/// NCBI TaxId: 3363454
/// </summary>
public abstract class Paranotropis : Leuciscidae, IParanotropis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Paranotropis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3363454;

    /// <inheritdoc />
    public virtual string GenusName => "Paranotropis";

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
