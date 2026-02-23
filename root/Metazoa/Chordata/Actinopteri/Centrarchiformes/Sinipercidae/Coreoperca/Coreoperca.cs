using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Sinipercidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Centrarchiformes.Sinipercidae.Coreoperca;

/// <summary>
/// Abstract class for Coreoperca (genus).
/// NCBI TaxId: 215344
/// </summary>
public abstract class Coreoperca : Sinipercidae, ICoreoperca
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Coreoperca";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 215344;

    /// <inheritdoc />
    public virtual string GenusName => "Coreoperca";

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
