using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Roraimia;

/// <summary>
/// Abstract class for Roraimia (genus).
/// NCBI TaxId: 589981
/// </summary>
public abstract class Roraimia : Furnariidae, IRoraimia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Roraimia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 589981;

    /// <inheritdoc />
    public virtual string GenusName => "Roraimia";

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
