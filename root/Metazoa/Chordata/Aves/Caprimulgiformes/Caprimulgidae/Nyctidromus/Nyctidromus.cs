using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Nyctidromus;

/// <summary>
/// Abstract class for Nyctidromus (genus).
/// NCBI TaxId: 235496
/// </summary>
public abstract class Nyctidromus : Caprimulgidae, INyctidromus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Nyctidromus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 235496;

    /// <inheritdoc />
    public virtual string GenusName => "Nyctidromus";

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
