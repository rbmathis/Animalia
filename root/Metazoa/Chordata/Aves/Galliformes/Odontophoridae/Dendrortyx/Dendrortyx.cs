using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Dendrortyx;

/// <summary>
/// Abstract class for Dendrortyx (genus).
/// NCBI TaxId: 1355952
/// </summary>
public abstract class Dendrortyx : Odontophoridae, IDendrortyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dendrortyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1355952;

    /// <inheritdoc />
    public virtual string GenusName => "Dendrortyx";

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
