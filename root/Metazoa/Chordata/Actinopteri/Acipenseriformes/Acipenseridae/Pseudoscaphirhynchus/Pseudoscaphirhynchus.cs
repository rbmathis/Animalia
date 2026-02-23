using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae.Pseudoscaphirhynchus;

/// <summary>
/// Abstract class for Pseudoscaphirhynchus (genus).
/// NCBI TaxId: 55289
/// </summary>
public abstract class Pseudoscaphirhynchus : Acipenseridae, IPseudoscaphirhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pseudoscaphirhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 55289;

    /// <inheritdoc />
    public virtual string GenusName => "Pseudoscaphirhynchus";

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
