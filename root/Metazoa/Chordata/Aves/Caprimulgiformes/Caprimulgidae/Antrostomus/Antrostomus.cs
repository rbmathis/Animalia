using AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Caprimulgiformes.Caprimulgidae.Antrostomus;

/// <summary>
/// Abstract class for Antrostomus (genus).
/// NCBI TaxId: 1854010
/// </summary>
public abstract class Antrostomus : Caprimulgidae, IAntrostomus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Antrostomus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1854010;

    /// <inheritdoc />
    public virtual string GenusName => "Antrostomus";

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
