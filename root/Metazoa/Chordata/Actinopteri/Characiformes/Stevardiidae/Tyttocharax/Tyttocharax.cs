using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Stevardiidae.Tyttocharax;

/// <summary>
/// Abstract class for Tyttocharax (genus).
/// NCBI TaxId: 930382
/// </summary>
public abstract class Tyttocharax : Stevardiidae, ITyttocharax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tyttocharax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 930382;

    /// <inheritdoc />
    public virtual string GenusName => "Tyttocharax";

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
