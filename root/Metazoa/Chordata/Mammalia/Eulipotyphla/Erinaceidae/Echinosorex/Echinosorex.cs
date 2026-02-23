using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Eulipotyphla.Erinaceidae.Echinosorex;

/// <summary>
/// Abstract class for Echinosorex (genus).
/// NCBI TaxId: 162629
/// </summary>
public abstract class Echinosorex : Erinaceidae, IEchinosorex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echinosorex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 162629;

    /// <inheritdoc />
    public virtual string GenusName => "Echinosorex";

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
