using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Certhiidae.Cinnycerthia;

/// <summary>
/// Abstract class for Cinnycerthia (genus).
/// NCBI TaxId: 241532
/// </summary>
public abstract class Cinnycerthia : Certhiidae, ICinnycerthia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cinnycerthia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241532;

    /// <inheritdoc />
    public virtual string GenusName => "Cinnycerthia";

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
