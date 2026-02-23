using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Clibanornis;

/// <summary>
/// Abstract class for Clibanornis (genus).
/// NCBI TaxId: 644979
/// </summary>
public abstract class Clibanornis : Furnariidae, IClibanornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clibanornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 644979;

    /// <inheritdoc />
    public virtual string GenusName => "Clibanornis";

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
