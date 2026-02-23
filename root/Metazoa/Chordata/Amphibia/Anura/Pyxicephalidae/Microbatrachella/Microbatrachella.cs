using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pyxicephalidae.Microbatrachella;

/// <summary>
/// Abstract class for Microbatrachella (genus).
/// NCBI TaxId: 317942
/// </summary>
public abstract class Microbatrachella : Pyxicephalidae, IMicrobatrachella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microbatrachella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 317942;

    /// <inheritdoc />
    public virtual string GenusName => "Microbatrachella";

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
