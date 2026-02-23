using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Oxymonacanthus;

/// <summary>
/// Abstract class for Oxymonacanthus (genus).
/// NCBI TaxId: 303723
/// </summary>
public abstract class Oxymonacanthus : Monacanthidae, IOxymonacanthus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Oxymonacanthus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303723;

    /// <inheritdoc />
    public virtual string GenusName => "Oxymonacanthus";

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
