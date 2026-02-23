using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leuciscidae.Pteronotropis;

/// <summary>
/// Abstract class for Pteronotropis (genus).
/// NCBI TaxId: 126322
/// </summary>
public abstract class Pteronotropis : Leuciscidae, IPteronotropis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pteronotropis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 126322;

    /// <inheritdoc />
    public virtual string GenusName => "Pteronotropis";

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
