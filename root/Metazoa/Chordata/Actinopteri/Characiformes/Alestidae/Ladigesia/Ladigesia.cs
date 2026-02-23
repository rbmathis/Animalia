using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Alestidae.Ladigesia;

/// <summary>
/// Abstract class for Ladigesia (genus).
/// NCBI TaxId: 304049
/// </summary>
public abstract class Ladigesia : Alestidae, ILadigesia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ladigesia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304049;

    /// <inheritdoc />
    public virtual string GenusName => "Ladigesia";

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
