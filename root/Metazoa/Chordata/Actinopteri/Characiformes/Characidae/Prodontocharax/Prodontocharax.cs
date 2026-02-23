using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Characidae.Prodontocharax;

/// <summary>
/// Abstract class for Prodontocharax (genus).
/// NCBI TaxId: 304072
/// </summary>
public abstract class Prodontocharax : Characidae, IProdontocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prodontocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 304072;

    /// <inheritdoc />
    public virtual string GenusName => "Prodontocharax";

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
