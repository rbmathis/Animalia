using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Tetraodontiformes.Monacanthidae.Nelusetta;

/// <summary>
/// Abstract class for Nelusetta (genus).
/// NCBI TaxId: 303725
/// </summary>
public abstract class Nelusetta : Monacanthidae, INelusetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nelusetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 303725;

    /// <inheritdoc />
    public virtual string GenusName => "Nelusetta";

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
