using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Acipenseriformes.Acipenseridae.Scaphirhynchus;

/// <summary>
/// Abstract class for Scaphirhynchus (genus).
/// NCBI TaxId: 7909
/// </summary>
public abstract class Scaphirhynchus : Acipenseridae, IScaphirhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Scaphirhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7909;

    /// <inheritdoc />
    public virtual string GenusName => "Scaphirhynchus";

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
