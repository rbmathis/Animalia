using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Sagittariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Sagittariidae.Sagittarius;

/// <summary>
/// Abstract class for Sagittarius (genus).
/// NCBI TaxId: 56257
/// </summary>
public abstract class Sagittarius : Sagittariidae, ISagittarius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sagittarius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 56257;

    /// <inheritdoc />
    public virtual string GenusName => "Sagittarius";

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
