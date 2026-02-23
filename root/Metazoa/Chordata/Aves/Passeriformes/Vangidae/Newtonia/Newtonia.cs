using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Newtonia;

/// <summary>
/// Abstract class for Newtonia (genus).
/// NCBI TaxId: 125289
/// </summary>
public abstract class Newtonia : Vangidae, INewtonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Newtonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125289;

    /// <inheritdoc />
    public virtual string GenusName => "Newtonia";

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
