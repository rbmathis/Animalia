using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Euryceros;

/// <summary>
/// Abstract class for Euryceros (genus).
/// NCBI TaxId: 125302
/// </summary>
public abstract class Euryceros : Vangidae, IEuryceros
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euryceros";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125302;

    /// <inheritdoc />
    public virtual string GenusName => "Euryceros";

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
