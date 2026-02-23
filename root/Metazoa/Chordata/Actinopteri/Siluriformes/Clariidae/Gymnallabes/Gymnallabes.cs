using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Clariidae.Gymnallabes;

/// <summary>
/// Abstract class for Gymnallabes (genus).
/// NCBI TaxId: 310928
/// </summary>
public abstract class Gymnallabes : Clariidae, IGymnallabes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Gymnallabes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 310928;

    /// <inheritdoc />
    public virtual string GenusName => "Gymnallabes";

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
