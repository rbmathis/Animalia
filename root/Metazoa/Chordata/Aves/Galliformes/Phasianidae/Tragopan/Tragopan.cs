using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Phasianidae.Tragopan;

/// <summary>
/// Abstract class for Tragopan (genus).
/// NCBI TaxId: 9069
/// </summary>
public abstract class Tragopan : Phasianidae, ITragopan
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tragopan";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9069;

    /// <inheritdoc />
    public virtual string GenusName => "Tragopan";

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
