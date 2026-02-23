using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Anabacerthia;

/// <summary>
/// Abstract class for Anabacerthia (genus).
/// NCBI TaxId: 329509
/// </summary>
public abstract class Anabacerthia : Furnariidae, IAnabacerthia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Anabacerthia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 329509;

    /// <inheritdoc />
    public virtual string GenusName => "Anabacerthia";

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
