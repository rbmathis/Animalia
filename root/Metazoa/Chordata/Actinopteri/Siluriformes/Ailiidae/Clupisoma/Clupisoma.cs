using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ailiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Ailiidae.Clupisoma;

/// <summary>
/// Abstract class for Clupisoma (genus).
/// NCBI TaxId: 555718
/// </summary>
public abstract class Clupisoma : Ailiidae, IClupisoma
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Clupisoma";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 555718;

    /// <inheritdoc />
    public virtual string GenusName => "Clupisoma";

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
