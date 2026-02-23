using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Odontophoridae.Dactylortyx;

/// <summary>
/// Abstract class for Dactylortyx (genus).
/// NCBI TaxId: 1355946
/// </summary>
public abstract class Dactylortyx : Odontophoridae, IDactylortyx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Dactylortyx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1355946;

    /// <inheritdoc />
    public virtual string GenusName => "Dactylortyx";

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
