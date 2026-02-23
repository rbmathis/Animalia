using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Spartonoica;

/// <summary>
/// Abstract class for Spartonoica (genus).
/// NCBI TaxId: 555346
/// </summary>
public abstract class Spartonoica : Furnariidae, ISpartonoica
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spartonoica";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 555346;

    /// <inheritdoc />
    public virtual string GenusName => "Spartonoica";

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
