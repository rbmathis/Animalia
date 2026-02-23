using AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Otidiformes.Otididae.Neotis;

/// <summary>
/// Abstract class for Neotis (genus).
/// NCBI TaxId: 156155
/// </summary>
public abstract class Neotis : Otididae, INeotis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Neotis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 156155;

    /// <inheritdoc />
    public virtual string GenusName => "Neotis";

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
