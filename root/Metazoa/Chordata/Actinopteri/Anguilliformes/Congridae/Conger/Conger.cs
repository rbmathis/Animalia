using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Congridae.Conger;

/// <summary>
/// Abstract class for Conger (genus).
/// NCBI TaxId: 7942
/// </summary>
public abstract class Conger : Congridae, IConger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7942;

    /// <inheritdoc />
    public virtual string GenusName => "Conger";

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
