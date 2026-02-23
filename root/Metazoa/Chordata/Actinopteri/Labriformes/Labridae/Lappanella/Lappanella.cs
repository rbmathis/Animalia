using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Lappanella;

/// <summary>
/// Abstract class for Lappanella (genus).
/// NCBI TaxId: 202591
/// </summary>
public abstract class Lappanella : Labridae, ILappanella
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Lappanella";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 202591;

    /// <inheritdoc />
    public virtual string GenusName => "Lappanella";

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
