using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeobarbus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeobarbus.Labeobarbus_nedgia_complex;

/// <summary>
/// Abstract class for Labeobarbus nedgia complex (no rank).
/// NCBI TaxId: 3455218
/// </summary>
public abstract class Labeobarbus_nedgia_complex : Labeobarbus, ILabeobarbus_nedgia_complex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Labeobarbus nedgia complex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3455218;

    /// <inheritdoc />
    public virtual string Description => "Taxon: Labeobarbus_nedgia_complex";
}
