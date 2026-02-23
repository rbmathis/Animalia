using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Crotophagidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Crotophagidae.Guira;

/// <summary>
/// Abstract class for Guira (genus).
/// NCBI TaxId: 30391
/// </summary>
public abstract class Guira : Crotophagidae, IGuira
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Guira";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30391;

    /// <inheritdoc />
    public virtual string GenusName => "Guira";

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
