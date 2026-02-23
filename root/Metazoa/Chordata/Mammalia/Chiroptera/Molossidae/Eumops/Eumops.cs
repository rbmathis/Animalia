using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Molossidae.Eumops;

/// <summary>
/// Abstract class for Eumops (genus).
/// NCBI TaxId: 27618
/// </summary>
public abstract class Eumops : Molossidae, IEumops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eumops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 27618;

    /// <inheritdoc />
    public virtual string GenusName => "Eumops";

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
