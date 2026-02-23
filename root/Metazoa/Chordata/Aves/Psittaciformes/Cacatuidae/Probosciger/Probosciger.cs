using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Cacatuidae.Probosciger;

/// <summary>
/// Abstract class for Probosciger (genus).
/// NCBI TaxId: 141838
/// </summary>
public abstract class Probosciger : Cacatuidae, IProbosciger
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Probosciger";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 141838;

    /// <inheritdoc />
    public virtual string GenusName => "Probosciger";

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
