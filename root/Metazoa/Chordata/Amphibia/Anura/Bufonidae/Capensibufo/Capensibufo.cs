using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Capensibufo;

/// <summary>
/// Abstract class for Capensibufo (genus).
/// NCBI TaxId: 119766
/// </summary>
public abstract class Capensibufo : Bufonidae, ICapensibufo
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Capensibufo";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 119766;

    /// <inheritdoc />
    public virtual string GenusName => "Capensibufo";

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
