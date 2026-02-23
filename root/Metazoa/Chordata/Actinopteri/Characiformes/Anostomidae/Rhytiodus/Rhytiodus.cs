using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Rhytiodus;

/// <summary>
/// Abstract class for Rhytiodus (genus).
/// NCBI TaxId: 642581
/// </summary>
public abstract class Rhytiodus : Anostomidae, IRhytiodus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhytiodus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 642581;

    /// <inheritdoc />
    public virtual string GenusName => "Rhytiodus";

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
