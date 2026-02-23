using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Otariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Otariidae.Eumetopias;

/// <summary>
/// Abstract class for Eumetopias (genus).
/// NCBI TaxId: 34885
/// </summary>
public abstract class Eumetopias : Otariidae, IEumetopias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eumetopias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34885;

    /// <inheritdoc />
    public virtual string GenusName => "Eumetopias";

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
