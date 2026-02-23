using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Delacourella;

/// <summary>
/// Abstract class for Delacourella (genus).
/// NCBI TaxId: 2821310
/// </summary>
public abstract class Delacourella : Estrildidae, IDelacourella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Delacourella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2821310;

    /// <inheritdoc />
    public virtual string GenusName => "Delacourella";

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
