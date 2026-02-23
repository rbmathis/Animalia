using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Cantherhines;

/// <summary>
/// Abstract class for Cantherhines (genus).
/// NCBI TaxId: 303711
/// </summary>
public abstract class Cantherhines : Monacanthidae, ICantherhines
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cantherhines";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303711;

    /// <inheritdoc />
    public virtual string GenusName => "Cantherhines";

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
