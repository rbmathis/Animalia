using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Channallabes;

/// <summary>
/// Abstract class for Channallabes (genus).
/// NCBI TaxId: 103214
/// </summary>
public abstract class Channallabes : Clariidae, IChannallabes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Channallabes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 103214;

    /// <inheritdoc />
    public virtual string GenusName => "Channallabes";

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
